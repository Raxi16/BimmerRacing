using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BimmerRacing.Areas.Identity.Data;
using BimmerRacing.Models;
using BimmerRacing.PaginatedList;

namespace BimmerRacing.Controllers
{
    public class ProductsController : Controller
    {
        private readonly BRContextDB _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductsController(BRContextDB context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Products
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.PriceSortParm = sortOrder == "ListPrice" ? "price_desc" : "ListPrice";

            if (searchString != null)
            {
                pageNumber = 1; // Reset to page 1 if a new search is performed
            }
            else
            {
                searchString = currentFilter; // Keep the current filter
            }

            ViewData["CurrentFilter"] = searchString;

            var products = from s in _context.Product select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }

            // Sorting
            switch (sortOrder)
            {
                case "name_desc":
                    products = products.OrderByDescending(p => p.ProductName);
                    break;
                case "ListPrice":
                    products = products.OrderBy(p => p.ListPrice);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(p => p.ListPrice);
                    break;
                default:
                    products = products.OrderBy(p => p.ProductName);
                    break;
            }

            int pageSize = 3;
            return View(await PaginatedList<Product>.CreateAsync(products.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [Authorize(Roles = "Admin")]
        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName");
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,ImageName,ProductImage,CategoryId,ListPrice,Quantity")] Product products)
        {
            if (products.ProductImage != null && products.ProductImage.Length > 0)
            {
                // Save Image to wwwroot/images
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(products.ProductImage.FileName);
                string extension = Path.GetExtension(products.ProductImage.FileName);
                products.ImageName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath, "images", products.ImageName);

                // Save the file
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await products.ProductImage.CopyToAsync(fileStream);
                }

                // Insert Record
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("ProductImage", "Please upload a valid image.");
            }

            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", products.CategoryId);
            return View(products);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ImageName,ProductImage,CategoryId,ListPrice,Quantity")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Update only the necessary fields, handle image upload if needed
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product != null)
            {
                _context.Product.Remove(product);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
    }
}
