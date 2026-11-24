# NewsHub

## Design decisions

### Article: record
- An article does not change after it is created. It only holds data.
- A record gives me a ready ToString and matches articles by their values.
- I did not use a struct because articles are saved in many places, and a struct gets copied each time.
- PublishedAt is set when the article is created, because it is published right after.
- Title and Author cannot be empty. If they are, an ArgumentException is thrown.