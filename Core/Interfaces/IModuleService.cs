using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IModuleService
    {
        public List<Module> getAllModules();
        public Module? getModule(int moduleId);
        public Module createModule(Module module);
        public Module updateModule(Module module);
        public void deleteModule(int moduleId);
    }
}
