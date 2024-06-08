﻿using ECommerce.Comment.Context;
using ECommerce.Comment.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Comment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]

    public class CommentsController : ControllerBase
    {
        private readonly CommentContext _context;

        public CommentsController(CommentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values=_context.UserComments.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCommemnt(UserComment userComment)
        {
            _context.UserComments.Add(userComment);
            _context.SaveChanges();
            return Ok("Yorum başarıyla eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteComment(int id)
        {
            var value=_context.UserComments.Find(id);
            _context.UserComments.Remove(value);
            _context.SaveChanges();
            return Ok("Yorum başarıyla silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var value= _context.UserComments.Find(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateComment(UserComment userComment)
        {
            _context.UserComments.Update(userComment);
            _context.SaveChanges();
            return Ok("Yorum başarıyla güncellendi");
        }

        [HttpGet("CommentListByProductId")]
        public IActionResult CommentListByProductId(string id)
        {
            var value = _context.UserComments.Where(x=>x.ProductId==id).ToList();
            return Ok(value);
        }
    }
}
