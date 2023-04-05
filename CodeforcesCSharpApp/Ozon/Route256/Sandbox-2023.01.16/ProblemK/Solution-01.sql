SELECT
    u.id,
    u.name
FROM
    users u
    JOIN orders o ON o.user_id = u.id
GROUP BY
    u.id,
    u.name
HAVING
    COUNT(*) > 0
ORDER BY
    u.name,
    u.id