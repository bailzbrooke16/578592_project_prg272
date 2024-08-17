using Core.Interfaces;
using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ModuleService : IModuleService
    {
        private readonly DataAccess _dataAccess;

        public ModuleService()
        {
            _dataAccess = new DataAccess();
        }
        public Module createModule(Module module)
        {
            return _dataAccess.createModule(module);
        }

        public void deleteModule(int moduleId)
        {
           _dataAccess.deleteModule(moduleId);
        }

        public List<Module> getAllModules()
        {
            return _dataAccess.getAllModules();
        }

        public Module? getModule(int moduleId)
        {
            return _dataAccess.getModule(moduleId);
        }

        public Module updateModule(Module module)
        {
            return _dataAccess.updateModule(module);
        }
    }
}
