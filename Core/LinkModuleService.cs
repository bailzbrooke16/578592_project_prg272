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
    public class LinkModuleService : ILinkModuleService
    {
        private readonly DataAccess _dataAccess;
        public LinkModuleService()
        {
            _dataAccess = new DataAccess();
        }
        public void addLinkModule(LinkModule linkModule)
        {
            _dataAccess.addLinkModule(linkModule);
        }

        public List<LinkModule> getAvailableModules(int studentNumber)
        {
            List<Module> modules = _dataAccess.getAllModules();
            List<LinkModule> linkModules = this.getLinkedModules(studentNumber);

            List<LinkModule> newLinkModules = new List<LinkModule>();

            foreach (Module module in modules)
            {
                bool isLinked = linkModules.Any(linkModule => linkModule.moduleId == module.code);

                if (!isLinked)
                {
                    LinkModule newLinkModule = new LinkModule
                    {
                        linkId = 0,
                        moduleId = module.code,
                        studentNumber = studentNumber
                    };

                    newLinkModules.Add(newLinkModule);
                }
            }

            return newLinkModules;

        }

        public List<LinkModule> getLinkedModules(int studentNumber)
        {
            return _dataAccess.getLinkedModules(studentNumber);
        }

        public void removeLinkModule(LinkModule linkModule)
        {
            _dataAccess.removeLinkModule(linkModule);
        }
    }
}
