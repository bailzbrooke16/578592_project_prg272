using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ILinkModuleService
    {
        public List<LinkModule> getLinkedModules(int studentNumber);

        public List<LinkModule> getAvailableModules(int studentNumber);
        public void addLinkModule(LinkModule linkModule);
        public void removeLinkModule(LinkModule linkModule);
    }
}
