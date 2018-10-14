using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using miOffers.DAL;

namespace myOffers.BLL
{
    public static class CommomBC
    {
        private static Entities _modelEntities;

        public static Entities modelEntities
        {
            get {
                if (_modelEntities == null) {
                    _modelEntities = new Entities();

                }
                return _modelEntities;

            }
            
        }

    }
}
