        private void DeleteDirectory(string target_dir)
        {
            string[] files = System.IO.Directory.GetFiles(target_dir);
            string[] dirs = System.IO.Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                System.IO.File.SetAttributes(file, FileAttributes.Normal);
                System.IO.File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            System.IO.Directory.Delete(target_dir, false);
        }
