using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data.EfBase
{
    public abstract class EfBaseRepository<TContext, TEntity> :
        //Aşağıdaki interfacelerin tamamı T tipinde değişken istiyordu. Ama tüm interfacelerin buraya implemente edilmesi demek EFBase'deki değişkeni bu interfacelere göndermek demek. O nedenle T yerine tEntity yazarız
        ISelectableRepository<TEntity>,
        IInsertableRepository<TEntity>,
        IDeletetableRepository<TEntity>,
        IUpdatetableRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext, new() //DI yaptığında oto newlwnsi diye. olmasa da olur. DBContext ten türemiyorsa bunu hiç kullanama demek. new keywordu ile hangi database olursa olsun newleyerek kullan demek
    {
        private readonly TContext _context; //readonly tannımlanmış değişken  db olsun olmasın sadece cons. yeni hali ile set edebiliriz. cons geçtikten sonra artık context dokunamayız ama okuyabiliriz. içeriğini değişemeyiz
        public EfBaseRepository() //boş cons. direkt db newliyor
        {
            _context= new TContext();
        }

        public EfBaseRepository(TContext context)
        {
            _context= context;
        }
        public TEntity Add(TEntity addValue)
        {
            _context.Set<TEntity>().Add(addValue); //Context: nortwind kullanacaksak onun entities bahsediyoruz demektir.o projeye ait context ve table kullanıyorum demektir. table demek dbset ile oluşturyoruz ya normlade ordan aklıma gelsin. table=set demek
            return addValue;
        }

        public List<TEntity> AddRange(List<TEntity> addValues)
        {
            _context.Set<TEntity>().AddRange(addValues);
            return addValues;
        }
        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public List<TEntity> GetBy(Func<TEntity, bool> whereCondition)
        {
            return _context.Set<TEntity>().Where(whereCondition).ToList();
        }

        public TEntity GetByID(object id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public void Delete(TEntity deletedValue, bool isHardDelete)
        {
            _context.Set<TEntity>().Remove(deletedValue);
        }
        
        //savechanges crud işlemlerine yazmayıp ayrı işleme çıkarmamız unitofwork dp uyguluyoruz anlamı taşır
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(TEntity updateValue)
        {
            _context.Set<TEntity>().Update(updateValue);
        }
    }
}
