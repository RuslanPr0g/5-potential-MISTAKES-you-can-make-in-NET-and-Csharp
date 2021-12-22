# 5 potential MISTAKES you can make in .NET/C#

- Async actions are not awaited - instead of Action use Func&lt;Task&gt;
- Making GetOrAdd in Concurrent Dictionary thread-safe - usually, all the methods in the ConcurrentDictionary are thread-safe and use Monitor and aquire lock to prevent other threads using it, <strong>BUT</strong> GetOrAdd is not thread safe!
- Clean way to have Internals visible for unit testing - all the internal keywords might be considered visible to some test projects for unit testing purposes
- Auto-implemented properties vs expression-bodied memebers
- Using LINQ for diffrent collections
