namespace MultiValueDictionary
{
    class MultiValueDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, List<TValue>> _dic;

        public MultiValueDictionary()
        {
            _dic = new Dictionary<TKey, List<TValue>>();
        }

        public IEnumerable<TKey> Keys => _dic.Keys;
        public int Count => _dic.Count;
        public void Add(TKey key, TValue value)
        {
            if (_dic.ContainsKey(key))
            {
                _dic[key].Add(value);
            }
            else
            {
                _dic.Add(key, new List<TValue>() { value });
            }
        }
        public void Clear()
        {
            _dic.Clear();
        }
        public bool ContainsKey(TKey key)
        {
            return _dic.ContainsKey(key);
        }
        public void Remove(TKey key)
        {
            _dic.Remove(key);
        }
        public void Remove(TKey key, TValue value)
        {
            if (_dic.TryGetValue(key, out var list))
            {
                list.Remove(value);
            } else
            throw new KeyNotFoundException();
        }
        public List<TValue> this[TKey key]
        {
            get
            {
                if (_dic.TryGetValue(key, out var list))
                    return list;
                throw new KeyNotFoundException();
            }
        }
        public List<TValue> Get(TKey key)
        {
            if (_dic.TryGetValue(key, out var list))
                return list;
            throw new KeyNotFoundException();
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var item in _dic)
            {
                var values = item.Value;
                foreach (var value in values)
                {
                    yield return new KeyValuePair<TKey, TValue>(item.Key, value);
                }
            }
        }
    }
}
