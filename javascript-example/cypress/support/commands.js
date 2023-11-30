Cypress.Commands.add('registerUser', (user) => {
  cy.window().then(win => {
    win.localStorage.setItem(user.email, JSON.stringify(user))
  })
})