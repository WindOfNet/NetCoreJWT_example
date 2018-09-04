# NetCoreJWT_example

get token
<pre>
GET /api/auth?user=abc
</pre>

result
<pre>
{
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiYWJjIiwiZXhwIjoxNTY3NTg0NDI0LCJpc3MiOiJpc3N1ZXIiLCJhdWQiOiJhdWRpZW5jZSJ9.0NhcxkranSJhCqMDigbVc9q3pekrTe1RfHiY_54qRLk"
}
</pre>

test auth
<pre>
GET /api/testauth
Headers: 
Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiYWJjIiwiZXhwIjoxNTY3NTg0NDI0LCJpc3MiOiJpc3N1ZXIiLCJhdWQiOiJhdWRpZW5jZSJ9.0NhcxkranSJhCqMDigbVc9q3pekrTe1RfHiY_54qRLk
</pre>

result
<pre>
hi abc
</pre>
