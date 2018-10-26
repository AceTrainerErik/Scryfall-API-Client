﻿using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis
{
    public class Symbology : BaseRestService, ISymbology
    {
        internal Symbology(HttpClient httpClient, ILogger logger, IMemoryCache cache = null) : base(httpClient, logger, cache) { }

        /// <summary>
        /// Retrieve all card symbols
        /// </summary>
        /// <returns></returns>
        public Task<ResultList<Symbol>> Get() => GetAsync<ResultList<Symbol>>("/symbology");

        /// <summary>
        /// Parses the given mana cost parameter and returns Scryfall’s interpretation.
        /// </summary>
        /// <returns></returns>
        public Task<ManaCost> ParseMana(string cost) => GetAsync<ManaCost>("/symbology/parse-mana");
    }
}