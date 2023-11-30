const user = {
  name: 'Fulano de Tal',
  email: 'fulano@mailinator.com',
  password: '123',
  accountNumber: '671-1',
  balance: 1000,
  logged: false
}

describe('Login', () => {

  before(() => {
    cy.registerUser(user)
  })

  it('Login with sucess', () => {
    cy.visit('/')
  
    cy.get('[placeholder="Informe seu e-mail"]')
      .first()
      .type(user.email)

    cy.get('[placeholder="Informe sua senha"]')
      .first()
      .type(user.password)


    cy.contains('Acessar')
      .click()

    cy.url('#modalText')
      .should('contain', '/home')
  })
})