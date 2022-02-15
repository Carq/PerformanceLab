using BenchmarkDotNet.Attributes;
using System.Net.Http.Json;
using ValueTaskVsTask.Dto;

namespace ValueTaskVsTask
{
    [MemoryDiagnoser]
    public class ValueTaskVsTaskBenchmark
    {
        [Benchmark]
        public async ValueTask ValueTask()
        {
            var httpClient = new HttpClient();

            for (int i = 0; i < 5; i++)
            {
                var result = await GetHolidaysValueTask(httpClient);
            }
        }

        [Benchmark]
        public async Task Task()
        {
            var httpClient = new HttpClient();

            for (int i = 0; i < 5; i++)
            {
                var result = await GetHolidaysTask(httpClient);
            }
        }

        public async Task<IList<HolidayDetailsDto>> GetHolidaysTask(HttpClient httpClient)
        {
            if (TaskCache.Data == null)
            {

                TaskCache.Data = await httpClient.GetFromJsonAsync<IList<HolidayDetailsDto>>("https://date.nager.at/api/v2/publicholidays/2022/PL");
            }

            return TaskCache.Data;
        }

        public async ValueTask<IList<HolidayDetailsDto>> GetHolidaysValueTask(HttpClient httpClient)
        {
            if (ValueTaskCache.Data == null)
            {
                ValueTaskCache.Data = await httpClient.GetFromJsonAsync<IList<HolidayDetailsDto>>("https://date.nager.at/api/v2/publicholidays/2022/PL");
            }

            return ValueTaskCache.Data;
        }
    }
}

