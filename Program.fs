open System

let salaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let highIncomeSalaries = 
    salaries |> List.filter (fun salary -> salary > 100000.0)

let calculateTax salary =
    match salary with
    | s when s <= 49020.0 -> s * 0.15 
    | s when s <= 98040.0 -> s * 0.205
    | s when s <= 151978.0 -> s * 0.26
    | s when s <= 216511.0 -> s * 0.29
    | _ -> salary * 0.33

let taxes = salaries |> List.map calculateTax

let incrementedSalaries = 
    salaries 
    |> List.map (fun salary -> if salary < 49020.0 then salary + 20000.0 else salary)

let filteredSum =
    salaries 
    |> List.filter (fun salary -> salary >= 50000.0 && salary <= 100000.0)
    |> List.reduce (+)

printfn "Original salaries: %A" salaries 
printfn "High-income salaries: %A" highIncomeSalaries
printfn "Original salaries: %A" salaries 
printfn "Taxes for all salaries: %A" taxes
printfn "Original salaries: %A" salaries 
printfn "Salaries incremented: %A" incrementedSalaries
printfn "Original salaries: %A" salaries 
printfn "Sum of salaries between $50,000 and $100,000: %f" filteredSum
printfn "Original salaries: %A" salaries 

let sumOfMultiplesOf3 n =
    let rec helper acc current =
        if current = 0 then acc
        else helper (acc + current) (current - 3)
    helper 0 n

let result = sumOfMultiplesOf3 27
printfn "Sum of multiples of 3 up to 27: %d" result

[<EntryPoint>]
let main argv =
    0
