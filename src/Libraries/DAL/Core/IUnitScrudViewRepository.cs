// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IUnitScrudViewRepository
    {
        /// <summary>
        /// Performs count on IUnitScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IUnitScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "UnitScrudView" class from IUnitScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "UnitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.UnitScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IUnitScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IUnitScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IUnitScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "UnitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.UnitScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IUnitScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "UnitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.UnitScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IUnitScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "UnitScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IUnitScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "UnitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.UnitScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IUnitScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "UnitScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IUnitScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "UnitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.UnitScrudView> GetFiltered(long pageNumber, string filterName);


    }
}