namespace LibraryManagementSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LibraryManagementSystem.Data.Common.Repositories;
    using LibraryManagementSystem.Data.Models.Assets;
    using LibraryManagementSystem.Services.Data.Contracts;
    using LibraryManagementSystem.Services.Mapping;

    public class LibraryAssetsService : ILibraryAssetsService
    {
        private readonly IDeletableEntityRepository<Asset> assetsRepository;

        public LibraryAssetsService(IDeletableEntityRepository<Asset> assetsRepository)
        {
            this.assetsRepository = assetsRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var assets = this.assetsRepository
                .All()
                .To<T>()
                .ToList();

            return assets;
        }

        public T GetById<T>(Guid id)
        {
            var asset = this.assetsRepository
                .AllAsNoTracking()
                .Where(a => a.Id == id)
                .To<T>()
                .FirstOrDefault();

            return asset;
        }
    }
}
