# 5 potential MISTAKES you can make in .NET/C#

- Async actions are not awaited - instead of action use Func&lt;Task&gt;
- Making GetOrAdd in Concurrent Dictionary thread-safe - usually, all the methods in the ConcurrentDictionary are thread-safe and use Monitor and aquire lock to prevent other threads using it, <strong>BUT</strong> GetOrAdd is not thread safe!
- Clean way to have Internals visible for unit testing
- Auto-implemented properties vs expression-bodied memebers
- Using LINQ for diffrent collections
