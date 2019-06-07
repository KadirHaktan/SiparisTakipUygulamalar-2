using Siparis.Core.CrossCuttingCornces.Caching.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Text.RegularExpressions;

namespace Siparis.Core.CrossCuttingCornces.Caching.Concart.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {       

        protected ObjectCache Cache
        {
            get { return MemoryCache.Default; }
        }
        

        public void Add(string key, object data, double CacheTime)
        {
            if (data == null)
            {
                return;
            }

            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(CacheTime)
            };

            Cache.Add(new CacheItem(key, data), policy);
        
                
        }

        public void Clear()
        {
            foreach(var c in Cache)
            {
                Remove(c.Key);
            }
        }

        public T Get<T>(string key)
        {
            return (T)Cache.Get(key);
        }

        public bool IsAdd(string key)
        {
            return Cache.Contains(key);
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }

        public void RemovebyPattern(string pattern)
        {
            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Compiled);

            var keysToRemove = Cache.Where(r => regex.IsMatch(r.Key)).Select(d => d.Key).ToList();

            foreach(var k in keysToRemove)
            {
                Cache.Remove(k);
            }

        }
    }
}
