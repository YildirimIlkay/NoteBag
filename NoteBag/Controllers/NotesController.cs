using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteBag.Data;
using NoteBag.Dtos;

namespace NoteBag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public NotesController(ApplicationDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IEnumerable<Note> GetNotes()
        {
            return db.Notes.OrderByDescending(x=>x.CreatedTime).ToList();
        }
        [HttpGet("{id}")]

        public ActionResult<Note> GetNote(int id)
        {
            var note= db.Notes.Find(id);
            if (note == null)
                return NotFound();

            return Ok(note);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNote(int id)
        {
            var note = db.Notes.Find(id);

            if (note == null)
                return NotFound();

            db.Remove(note);
            db.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public ActionResult<Note> PostNote(PostNoteDto dto)
        {
            if (ModelState.IsValid)
            {
                var note = new Note() { Title = dto.Title, Content = dto.Content };
                db.Notes.Add(note);
                db.SaveChanges();

                return CreatedAtAction(nameof(GetNote), new { id = note.Id }, note);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public ActionResult<Note> PutNote(int id, PutNoteDto dto)
        {
            if (id != dto.Id)
                return BadRequest();

            var note = db.Notes.Find(id);

            if (note == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                note.Title = dto.Title;
                note.Content = dto.Content;
                note.ModifiedTime = DateTimeOffset.Now;
                db.SaveChanges();

                return Ok(note);
            }

            return BadRequest(ModelState);
        }

    }
}
