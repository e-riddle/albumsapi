using System;
using System.Collections.Generic;
using System.Text;
using Album.DataAccess.EF.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;


namespace Album.DataAccess.EF.Repository
{
    public class ArtistRepository : EfRepositoryBase<AlbumViewerContext, Artist>
    {
        public ArtistRepository(AlbumViewerContext context)
            : base(context)
        { }

        public async Task<List<Artist>> GetArtists()
        {
            return await Context.Artists
                    .OrderBy(x => x.ArtistName)
                    .ToListAsync();


        }

       
    }

}
