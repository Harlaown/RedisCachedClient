﻿using System;
using ConcurrentObservableCollections.ConcurrentObservableDictionary;
using RedisCachedClient;
using StackExchange.Redis;

namespace RedisClientDemo
{
    public class RedisClientObserver : IRedisClientObserver
    {
        public void OnEventOccur(DictionaryChangedEventArgs<string, RedisValue> args)
        {
            Console.WriteLine($"[{args.Action}] {args.Key}: {args.OldValue} -> {args.NewValue} from observer");
        }
    }
}
