using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Robot.Data;
using Robot.Models;

namespace Robot.Controllers
{
    public class ScenesController : Controller
    {
        private readonly RobotContext _context;

        public ScenesController(RobotContext context)
        {
            _context = context;
        }

        // GET: Scenes
        public IActionResult Index()
        {
            var scenes = _context.Scenes
                .AsNoTracking();
            return new JsonResult(scenes);
        }

        // GET: Scenes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scene = await _context.Scenes
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.SceneID == id);
            if (scene == null)
            {
                return NotFound();
            }

            return View(scene);
        }
    }
}