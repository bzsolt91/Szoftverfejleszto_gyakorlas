SELECT versenyzo_rajtszama, 
       COUNT(versenyzo_rajtszama), 
       AVG(versenyzo_helyezese)
FROM versenyzok
GROUP BY versenyzo_rajtszama
HAVING AVG(versenyzo_helyezese) < 10
ORDER BY AVG(versenyzo_helyezese);