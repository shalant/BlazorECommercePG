﻿using BlazorECommerce.Server.Migrations;

namespace BlazorECommerce.Server.Services.CategoryService
{
	public interface ICategoryService
	{
		Task<ServiceResponse<List<Categories>>> GetCategories();
	}
}
