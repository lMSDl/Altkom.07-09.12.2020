using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;
using WPCSharp.DesignPatterns.Creational.FactoryMethod;

namespace WPCSharp.DesignPatterns.Creational.ObjectPool
{
    public static class Client
    {
        public static void Execute()
        {
            //var objectPool = new ObjectPool<Item>(1000, () => new Item());
            var objectPool = new ObjectPool<Item>(1000, () => new Item(), x => !x.IsVisible);
            while (true)
            {
                var item = objectPool.Acquire();
                if (item == null) {
                    Thread.Sleep(1);
                    continue;
                }
                item.IsVisible = true;
                Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; /*objectPool.Release(item);*/ });
            }
        }
    }
}
