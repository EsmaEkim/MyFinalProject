using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class : kann ein Referenztyp sein.
    // EEntity: kann IEntity sein oder ein Objekt, das IEntity implementiert.“
    // new(): es sollte instanziierbar sein.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Dieser Code ermöglicht es uns, Filter anzuwenden, zum Beispiel: Produkte nach einem festgelegten Preisbereich aufzulisten.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
