using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDal
{
    public static class MovieDalFactory
    {
        public static TEntity Create<TEntity>() where TEntity : class
        {
            var t = typeof(TEntity);

            switch (t.Name)
            {
                case "IActorDao":
                    return new ActorDao() as TEntity;
                case "IMovieDao":
                    return new MovieDao() as TEntity;
                default:
                    throw new Exception("Unknown type");

            }

        }


    }
}
