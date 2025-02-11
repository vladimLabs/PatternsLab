using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab
{
    // Паттерн Proxy
    public interface IService
    {
        string GetData();
    }

    public class RealService : IService
    {
        public string GetData()
        {
            System.Threading.Thread.Sleep(3000); // Эмуляция задержки
            return "Данные от RealService";
        }
    }

    public class ProxyService : IService
    {
        private RealService _realService;
        private string _cachedData;
        private DateTime _lastRequestTime;
        private readonly TimeSpan _cacheDuration = TimeSpan.FromSeconds(5);

        public ProxyService()
        {
            _realService = new RealService();
        }

        public string GetData()
        {
            if (_cachedData == null || DateTime.Now - _lastRequestTime > _cacheDuration)
            {
                _cachedData = _realService.GetData();
                _lastRequestTime = DateTime.Now;
                Console.WriteLine("Получены новые данные.");
            }
            else
            {
                Console.WriteLine("Возвращаются кэшированные данные.");
            }
            return _cachedData;
        }
    }
}
