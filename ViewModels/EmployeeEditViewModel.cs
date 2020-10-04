using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore01_2._1.ViewModels
{
    public class EmployeeEditViewModel: EmplyoeeCreateViewModel
    {

        public int Id { get; set; }

        public string ExistingPhotoPath { get; set; }


    }
}
