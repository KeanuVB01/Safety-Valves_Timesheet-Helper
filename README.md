# Safety-Valves_Timesheet-Helper
---

### Table of Contents
#### 1. Assumptions
#### 2. Features
#### 3. Program Flow
---
#### 1. Assumptions
+ Safety & Control Valves use hardcopies for timesheets
+ Their employees write down their time-in and time-out
+ The company just want to collect the overtime or time not worked
+ Monday-Thursday normal hours = 8 Hours 
+ Friday normal hours = 5 hours
+ The employees agreed on having 15 minutes extra lunch, but then start 15 minutes earlier

---
#### 2. Features
#### **_Input_**

>+  The User enters the time-in & time-out

>+  The user then selects the appropriate modifiers

>+  After selecting the modifiers, the user presses calculate & output is shown

#### **_Modifiers_**

>+ Lunch - A worker is assigned 1x lunch = 45 minutes & 2x quick breaks = 15 minutes each. This will be subtracted from total hours.

>+ Open - The company requires one worker to open the workshop early, they get a bonus 2 hours added to their total hours.

>+ Friday - Since Friday is only 5 hours, a modifier was required to calculate overtime. *Friday & Lunch cannot be selected at the same time

#### **_Output_**

>+ The output is numbered lines, showing: Time-in, Time-out, Difference (Overtime or under), Modifiers.

---
#### 2. Program Flow
1. Input Time-in
2. Input Time-out
3. Select Modifiers applicable
4. Press Calculate Button
5. View Output
6. Repeat 1-5 if needed else press Clear Button
