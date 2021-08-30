# Write your MySQL query statement below
SELECT id, movie, description, rating
FROM cinema
WHERE MOD(id, 2) <> 0 AND description NOT LIKE '%boring%'
ORDER BY rating DESC