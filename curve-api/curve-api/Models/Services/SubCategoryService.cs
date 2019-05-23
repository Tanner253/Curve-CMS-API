﻿using curve_api.Data;
using curve_api.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Services
{
    public class SubCategoryService : ISubcategoryManager
    {
        private readonly CurveDBContext _context;

        public SubCategoryService(CurveDBContext context)
        {
            _context = context;
        }


        public async Task<SubCategory> CreateSubCategory(SubCategory subCategory)
        {
            _context.Add(subCategory);
            await _context.SaveChangesAsync();
            return subCategory;
        }

        public async Task DeleteSubCategory(int id)
        {
            SubCategory sc = await _context.Subcategories.FindAsync(id);
            if (sc != null)
            {
                _context.Remove(sc);
                _context.SaveChanges();
            }
        }

        public async Task<List<SubCategory>> GetAllByCategoryId(int categoryId)
        {
            return await _context.Subcategories.Where(sc => sc.CategoryId == categoryId).ToListAsync();
        }

        public async Task<SubCategory> GetSubCategoryById(int id)
        {
            return await _context.Subcategories.FindAsync(id);
        }

        public async Task<SubCategory> UpdateSubCategory(SubCategory subCategory)
        {
            _context.Update(subCategory);
            await _context.SaveChangesAsync();
            return subCategory;
        }
    }
}
