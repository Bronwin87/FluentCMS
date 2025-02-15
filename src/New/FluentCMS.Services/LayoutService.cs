﻿namespace FluentCMS.Services;

public interface ILayoutService
{
    Task<Layout> Create(Layout layout, CancellationToken cancellationToken = default);
    Task<Layout> Delete(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Layout>> GetAll(Guid siteId, CancellationToken cancellationToken = default);
    Task<Layout> GetById(Guid siteId, Guid id, CancellationToken cancellationToken = default);
    Task<Layout> Update(Layout layout, CancellationToken cancellationToken);
}

public class LayoutService(ILayoutRepository layoutRepository) : ILayoutService
{
    public async Task<Layout> GetById(Guid siteId, Guid id, CancellationToken cancellationToken = default)
    {
        var siteLayouts = await GetAll(siteId, cancellationToken);

        var layout = siteLayouts.SingleOrDefault(layout => layout.Id.Equals(id));

        return layout ?? throw new AppException(ExceptionCodes.LayoutNotFound);
    }

    public async Task<IEnumerable<Layout>> GetAll(Guid siteId, CancellationToken cancellationToken = default)
    {
        return await layoutRepository.GetAllForSite(siteId, cancellationToken);
    }

    public async Task<Layout> Create(Layout layout, CancellationToken cancellationToken = default)
    {
        return await layoutRepository.Create(layout, cancellationToken) ??
            throw new AppException(ExceptionCodes.LayoutUnableToCreate);
    }

    public async Task<Layout> Update(Layout layout, CancellationToken cancellationToken)
    {
        return await layoutRepository.Update(layout, cancellationToken) ??
            throw new AppException(ExceptionCodes.LayoutUnableToUpdate);
    }

    public async Task<Layout> Delete(Guid id, CancellationToken cancellationToken = default)
    {
        return await layoutRepository.Delete(id, cancellationToken) ??
            throw new AppException(ExceptionCodes.LayoutUnableToDelete);
    }
}
