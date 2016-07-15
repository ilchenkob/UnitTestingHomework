using System;
using System.Linq;

namespace Logic
{
    public class MasterService : IMasterService
    {
        private IAlgoService _algoService;

        private IDataService _dataService;
        
        public MasterService(IAlgoService algo, IDataService data)
        {
            _algoService = algo;
            _dataService = data;
        }

        public int MakeMagic()
        {
            var data = _dataService.GetAllData();
            if (data == null || !data.Any())
            {
                throw new InvalidOperationException("We have no data to process");
            }

            return _algoService.DoubleSum(data);;
        }

        //TODO: Make more methods
    }
}