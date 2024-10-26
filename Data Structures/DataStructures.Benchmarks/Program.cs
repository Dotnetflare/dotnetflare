#region Array
BenchmarkRunner.Run<ArrayOperationsBenchmark>();
BenchmarkRunner.Run<DynamicArrayBenchmark>();
#endregion

#region Stack
BenchmarkRunner.Run<ArrayStackBenchmark>();
BenchmarkRunner.Run<ListStackBenchmark>();
BenchmarkRunner.Run<QueueStackBenchmark>();
BenchmarkRunner.Run<LinkedListStackBenchmark>();
BenchmarkRunner.Run<StackWrapperBenchmark>();
BenchmarkRunner.Run<ConcurrentStackWrapperBenchmarks>();
#endregion