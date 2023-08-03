using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using shoppingAPP_MVC.Model.EF;

namespace shoppingAPP_MVC.Controllers
{
    public class ProductListsController : Controller
    {
        private readonly ShoppingDbMvcContext _context = new ShoppingDbMvcContext();

        //public ProductListsController(ShoppingDbMvcContext context)
        //{
        //    _context = context;
        //}

        // GET: ProductLists
        public async Task<IActionResult> Index()
        {
              return _context.ProductLists != null ? 
                          View(await _context.ProductLists.ToListAsync()) :
                          Problem("Entity set 'ShoppingDbMvcContext.ProductLists'  is null.");
        }

        // GET: ProductLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductLists == null)
            {
                return NotFound();
            }

            var productList = await _context.ProductLists
                .FirstOrDefaultAsync(m => m.PId == id);
            if (productList == null)
            {
                return NotFound();
            }

            return View(productList);
        }

        // GET: ProductLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PId,PName,PCategory,PPrice,PIsInStock")] ProductList productList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productList);
        }

        // GET: ProductLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductLists == null)
            {
                return NotFound();
            }

            var productList = await _context.ProductLists.FindAsync(id);
            if (productList == null)
            {
                return NotFound();
            }
            return View(productList);
        }

        // POST: ProductLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PId,PName,PCategory,PPrice,PIsInStock")] ProductList productList)
        {
            if (id != productList.PId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductListExists(productList.PId))
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
            return View(productList);
        }

        // GET: ProductLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductLists == null)
            {
                return NotFound();
            }

            var productList = await _context.ProductLists
                .FirstOrDefaultAsync(m => m.PId == id);
            if (productList == null)
            {
                return NotFound();
            }

            return View(productList);
        }

        // POST: ProductLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductLists == null)
            {
                return Problem("Entity set 'ShoppingDbMvcContext.ProductLists'  is null.");
            }
            var productList = await _context.ProductLists.FindAsync(id);
            if (productList != null)
            {
                _context.ProductLists.Remove(productList);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductListExists(int id)
        {
          return (_context.ProductLists?.Any(e => e.PId == id)).GetValueOrDefault();
        }
    }
}
