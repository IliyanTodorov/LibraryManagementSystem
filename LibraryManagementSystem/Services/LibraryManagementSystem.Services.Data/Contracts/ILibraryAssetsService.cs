namespace LibraryManagementSystem.Services.Data.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ILibraryAssetsService
    {
        T GetById<T>(Guid id);

        IEnumerable<T> GetAll<T>();
    }
}
