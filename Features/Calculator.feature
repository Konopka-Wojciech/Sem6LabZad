Feature: Tax calculation
  In order to pay the correct amount of taxes
  As a taxpayer
  I want to calculate my income tax

Scenario: Calculate tax for income below first threshold
  Given my annual income is 100000
  When I calculate the tax
  Then the tax amount should be 17000

Scenario: Calculate tax for income at first threshold
  Given my annual income is 120000
  When I calculate the tax
  Then the tax amount should be 20400

Scenario: Calculate tax for income above first threshold
  Given my annual income is 150000
  When I calculate the tax
  Then the tax amount should be 30000