using Microsoft.AspNetCore.Mvc;


namespace KPL_MOD10_SE_48_04_103022400137_RAH.Controllers
{

    

    [ApiController]
    [Route("api/[controller]")]
    public class Controllers : ControllerBase
    {
        private static List<Games> _games = new List<Games>()
        {
            new Games
            {
             id = 1,
             Nama = "Valorant",
             Developer = "Riot Games",
             TahunRilis =  2020,
             Genre = "FPS",
             Rating = 8.5,
             Platform = ["PC"],
             Mode = ["Multiplayer"],
             isOnline = true,
             Harga = 0
            },


            new Games
            {
             id = 2,
             Nama = "GTA V",
             Developer = "Rockstar Games",
             TahunRilis = 2013,
             Genre = "Open World",
             Rating = 9.5,
             Platform = ["PC","PS4","PS5","XBOX"],
             Mode = ["Singleplayer"],
             isOnline = true,
             Harga = 300000
            },


            new Games
            {
             id = 3,
             Nama = "The Witcher 3",
             Developer = "CD Projekt Red",
             TahunRilis = 2015,
             Genre = "RPG",
             Rating = 9.7,
             Platform = ["PC","PS4","PS5","XBOX","Switch"],
             Mode = ["Singleplayer"],
             isOnline = false,
             Harga = 250000
            },
        };

        [HttpGet]

        public IEnumerable<Games> Get()
        {
            return _games;
        }

        [HttpGet("{id}")]
        public Games Get(int id)
        {
            return _games[id];
        }

        [HttpPost]
        public void Post(Games game)
        {
            _games.Add(game);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id,Games update)
        {
            var index = _games.FindIndex(g =>  g.id == id);
            if (index == -1)
            {
                return NotFound();
            }
            _games[index] = update; 
            return Ok(update);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _games.RemoveAt(id);
        }
    }
}
