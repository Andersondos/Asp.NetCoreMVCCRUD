using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreMVCCRUD.Models;
using Microsoft.AspNetCore.Identity;

namespace Asp.netCoreMVCCRUD.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioContext _context;

        public FuncionarioController(FuncionarioContext context)
        {
            _context = context;
        }

        // GET: Funcionario
        public async Task<IActionResult> Index()
        {
            return View(await _context.Funcionarios.ToListAsync());
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConectarLogin(FuncionarioModel usuario)
        {


            var userEmail = _context.Funcionarios.Where(f => f.Email == usuario.Email).Count();
            var userSenha = _context.Funcionarios.Where(f => f.Senha == usuario.Senha).Count();

            if (userSenha >= 1 && userEmail >= 1)
            {
                return RedirectToAction("index");
            }
            else
            {

                ViewBag.Message = "E-mail ou senha invalido";
                return View("Login");
            }
            

        }

        //GET: Funcionario/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new FuncionarioModel());
            else
                return View(_context.Funcionarios.Find(id));
        }

        // POST: Funcionario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("FuncionarioID,NomeCompleto,EmpCode,Cargo,localizacao,Email,Senha")] FuncionarioModel funcionario)
        {
            if (ModelState.IsValid)
            {
                if (funcionario.FuncionarioID == 0)
                    _context.Add(funcionario);
                else
                    _context.Update(funcionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        // GET: Funcionario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var funcionario = await _context.Funcionarios.FindAsync(id);
            _context.Funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
