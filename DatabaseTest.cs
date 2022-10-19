using System.Collections.ObjectModel;

namespace Lab4
{
    public class DatabaseTest :IDatabase
    {
        ObservableCollection<Entry> entries = new ObservableCollection<Entry>();
        public DatabaseTest()
        {

        }

        /// <summary>
        /// Finds a specific entry
        /// </summary>
        /// <param name="id">id to find</param>
        /// <returns>the Entry (if available)</returns>
        public Entry FindEntry(int id)
        {
            foreach (Entry entry in entries)
            {
                if (entry.Id == id)
                {
                    return entry;
                }
            }
            return null;
        }

        /// <summary>
        /// Adds an entry to the database
        /// </summary>
        /// <param name="entry">the entry to add</param>
        public void AddEntry(Entry entry)
        {
            int maxId = 0;
 
                if (entries.Count > 1)//if the Observable Collection length is greater than 1 
                {
                    int id = entries[0].Id;//make id equal the first index

                    for (int i = 1; i < entries.Count; i++)//compare each index for the max ID
                    {
                        if (id < entries[i].Id)
                        {
                            maxId = entries[i].Id;
                        }
                    }
                }
                else if (entries.Count == 1)
                {
                    maxId = entries[0].Id;
                }

            entry.Id = maxId + 1;
            entries.Add(entry);  
            
           
        }

        /// <summary>
        /// Deletes an entry 
        /// </summary>
        /// 
        /// <param name="entry">An entry, which is presumed to exist</param>
        public bool DeleteEntry(Entry entry)
        {
            bool success = entries.Remove(entry);
            if (success)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Edits an entry
        /// </summary>
        /// <param name="replacementEntry"></param>
        /// <returns>true if editing was successful</returns>
        public bool EditEntry(Entry replacementEntry)
        {
            foreach (Entry entry in entries) // iterate through entries until we find the Entry in question
            {
                if (entry.Id == replacementEntry.Id) // found it
                {
                    entry.Answer = replacementEntry.Answer;
                    entry.Clue = replacementEntry.Clue;
                    entry.Difficulty = replacementEntry.Difficulty;
                    entry.Date = replacementEntry.Date;

                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// Sort by answer
        /// </summary>
        /// <returns>true if sorted</returns>
        public bool SortByAnswer()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sort by clue
        /// </summary>
        /// <returns>true if sorted</returns>
        public bool SortByClue()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves all the entries
        /// </summary>
        /// <returns>all of the entries</returns>
        public ObservableCollection<Entry> GetEntries()
        {
            return entries;
        }
    }
}
  

