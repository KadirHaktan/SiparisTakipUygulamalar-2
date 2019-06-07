using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Core.CrossCuttingCornces.Caching.Abstract
{
  public interface ICacheManager
    {
        T Get<T>(string key);
        void Add(string key, object data, double CacheTime);
        bool IsAdd(string key);
        void Remove(string key);
        void RemovebyPattern(string pattern);
        void Clear();
    }
}
