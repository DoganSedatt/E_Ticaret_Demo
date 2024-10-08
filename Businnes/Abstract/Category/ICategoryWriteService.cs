﻿using Businnes.Requests.Category;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes
{
    public interface ICategoryWriteService
    {
        Task<Category> AddCategoryAsync(AddCategoryRequest request);
        Task<List<Category>> AddRangeCategoriesAsync(IEnumerable<AddRangeCategoryRequest> categories);
        Task<Category> DeleteCategoryByIdAsync(Guid id);
        Task<Category> DeleteCategoryAsync(DeleteByCategoryRequest category);
        Task<Category> UpdateCategoryAsync(UpdateCategoryRequest category);
    }
}
