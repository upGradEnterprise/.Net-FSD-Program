 -- Example:  Recursive CTE to Generate a Number Sequence
 
 
 WITH NumberSequence AS (
    -- Anchor member: starting point
    SELECT 1 AS Number
    UNION ALL
    -- Recursive member: increments the number
    SELECT Number + 1
    FROM NumberSequence
    WHERE Number < 10
)
SELECT Number
FROM NumberSequence;