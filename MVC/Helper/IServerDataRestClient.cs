using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Models;

namespace MVC.Helper
{
    public interface IServerDataRestClient
    {
        void Add(ServerDataModel serverDataModel);
        void Delete(int id);
        IEnumerable<ServerDataModel> GetAll();
        ServerDataModel GetById(int id);
        ServerDataModel GetByIP(int ip);
        ServerDataModel GetByType(int type);
        void Update(ServerDataModel serverDataModel);
    }
}
