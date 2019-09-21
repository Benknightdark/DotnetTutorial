using System.Collections.Generic;
using System.Linq;
using DotnetTutorial.Models.DBModels;

namespace DotnetTutorial.services
{
    public class YoService
    {
        private YoDBContext _db;
        public YoService(YoDBContext db){
            _db=db;
        }
        public IEnumerable<user> GetUser(){
            return _db.user.AsEnumerable();
        }
    }
}