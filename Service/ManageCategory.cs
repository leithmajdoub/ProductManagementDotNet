using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Service
{
    public class ManageCategory
    {
        private List<Category> categories;
        public ManageCategory(List<Category> categories) {
            this.categories = categories;
        }
    }
}
