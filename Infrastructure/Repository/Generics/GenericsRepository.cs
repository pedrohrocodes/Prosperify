using System.Runtime.InteropServices;
using Domain.Interfaces.Generics;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;

namespace Infrastructure.Repository.Generics;

public class GenericsRepository<T> : IDisposable, IGeneric<T> where T : class
{
    private readonly DbContextOptions<ContextBase> _dbContextOptions;
    
    public GenericsRepository()
    {
        this._dbContextOptions = new DbContextOptions<ContextBase>();
    }
    
    public async Task Add(T Object)
    {
        using (var data = new ContextBase(_dbContextOptions))
        {
            await data.Set<T>().AddAsync(Object);
            await data.SaveChangesAsync();
        }
    }

    public async Task Update(T Object)
    {
        using (var data = new ContextBase(_dbContextOptions))
        {
            data.Set<T>().Update(Object);
            await data.SaveChangesAsync();
        }
    }

    public async Task Delete(T Object)
    {
        using (var data = new ContextBase(_dbContextOptions))
        {
            data.Set<T>().Remove(Object);
            await data.SaveChangesAsync();
        }
    }

    public async Task<T> GetEntityById(Guid Id)
    {
        using (var data = new ContextBase(_dbContextOptions))
        {
            return await data.Set<T>().FindAsync(Id);
        }
    }

    public async Task<List<T>> List()
    {
        using (var data = new ContextBase(_dbContextOptions))
        {
            return await data.Set<T>().ToListAsync();
        }
    }

    #region Disposed
    // https://learn.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
    
    // Flag: Has Dispose already been called?
    private bool _disposed = false;

    // Instantiate a SafeHandle instance.
    private SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);
    
    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        if (disposing)
        {
            _handle.Dispose();
            // Free any other managed objects here.
        }

        _disposed = true;
    }
    
    #endregion
}