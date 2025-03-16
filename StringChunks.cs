using System;

namespace Mammon {
	/* 
	 * Class PullStringChunks contains several methods useful for grabbing arbitrary parts of a given string,
	 * called "Chunks", for generic use in string handling programs. No guarantees are made yet as to the
	 * effectiveness or efficiency of the provided methods.
	 */

	public class StringChunks {
		// PullCharIndexes(string s, char c) Returns a List<int> of zero-based indexes of the specified character from the specified string. 
		// Example usage:
		// var indexes = PullCharIndexes("Greetings flesh sacks", 'e'); 
		// Will return a List<int> with the values 2, 3, 12.
		public List<int> PullCharIndexes(string s, char c) {
			List<int> ret = new List<int>();

			for (int i = 0; i < s.Length; i++) {
				if (s[i] == c) {
					ret.Add(i);
				}
			}

			return ret;
		}

		// PullStringChunk(string s, int start, int end) Overload returns a substring from the specified start and end indexes
		// from the specified string.
		public string PullStringChunk(string s, int start_idx, int end_idx) {
			string ret = s.Substring(start_idx, end_idx - start_idx);

			return ret;
		}

		// PullStringChunk(string s, List<int> start, List<int> end) Overload returns a List<string> from the specified index map.
		// Example usage: 
		// string s = "Hello there";
		// var starting_indexes = PullCharIndexes(s, 'H'); var ending_indexes = PullCharIndexes(s, 'r');
		// var chunks = PullStringChunk(s, starting_indexes, ending_indexes);
		// Will return a List<string> with one entry of "ello the".
		public List<string> PullStringChunk(string s, List<int> start_idx, List<int> end_idx) {
			int s_size = start_idx.Count;
			List<string> ret = new(s_size);

			for (int i = 0; i < s_size; i++) {
				ret.Add(s.Substring(start_idx[i], end_idx[i] - start_idx[i]));
			}

			return ret;
		}
	}
}