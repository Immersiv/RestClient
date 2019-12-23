namespace Proyecto26
{
    public interface JsonParser
    {
        /// <summary>
        /// Get an array of objects when the response is an array "[]" instead of a valid JSON "{}"
        /// </summary>
        /// <returns>An array of objects.</returns>
        /// <param name="json">An array returned from the server.</param>
        /// <typeparam name="T">The element type of the array.</typeparam>
        T[] ArrayFromJson<T>(string json);

        T[] FromJsonString<T>(string json);

        string ArrayToJsonString<T>(T[] array);

        string ArrayToJsonString<T>(T[] array, bool prettyPrint);

        string ToJson(object obj);

        T FromJson<T>(string json);
    }
}
