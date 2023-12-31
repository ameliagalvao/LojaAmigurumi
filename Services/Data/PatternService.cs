﻿using LojaAmigurumi.Data;
using LojaAmigurumi.Models;
using System.Text.RegularExpressions;

namespace LojaAmigurumi.Services.Data
{
    public class PatternService : IPatternService
    {
        private PatternDbContext _context;
        public PatternService(PatternDbContext context)
        {
            _context = context;
        }
        public void Incluir(Pattern pattern)
        {
            _context.Pattern.Add(pattern);
            _context.SaveChanges();
        }

        public Pattern Obter(int id)
        {
            return _context.Pattern.SingleOrDefault(item => item.PatternId == id);
        }

        public IList<Pattern> ObterTodas()
        {
            return _context.Pattern.ToList();
        }

        void IPatternService.Alterar(Pattern pattern)
        {
            var patternEncontrada = Obter(pattern.PatternId);
            patternEncontrada.PatternName = pattern.PatternName;
            patternEncontrada.PatternDescription = pattern.PatternDescription;
            patternEncontrada.PatternImageUri = pattern.PatternImageUri;
            patternEncontrada.PatternPrice = pattern.PatternPrice;
            patternEncontrada.NivelId = pattern.NivelId;
            patternEncontrada.Categorias = pattern.Categorias;
            _context.SaveChanges();
        }

        void IPatternService.Excluir(int id)
        {
            var pattern = Obter(id);
            _context.Pattern.Remove(pattern);
            _context.SaveChanges();
        }

        IList<Categoria> IPatternService.ObterTodasCategorias()
        {
            return _context.Categoria.ToList();
        }

        IList<Nivel> IPatternService.ObterTodosNiveis()
        {
            return _context.Nivel.ToList();
        }
    }
}