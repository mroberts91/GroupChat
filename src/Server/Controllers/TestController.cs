using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Server.Controllers
{
    public class TestController : ControllerBase
    {
        //[Authorize]
        public IActionResult Message()
        {
            var foo = JsonSerializer.Serialize(new Message());
            return Ok(foo);
        }
    }

    class Message
    {
        static readonly Random random = new Random();
        public string Text => "This is a Message from a secured endpoint";
        public int MagicNumber => random.Next();
    }
}
