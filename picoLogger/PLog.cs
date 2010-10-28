using System;

namespace picoLogger {
    class PLog {

        private static string path = "log.txt";

        public static void WriteLine(string line) {
            try {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true)) {
                    file.WriteLine(line);
                }
            } catch (Exception e) {

            }
        }
    }
}
