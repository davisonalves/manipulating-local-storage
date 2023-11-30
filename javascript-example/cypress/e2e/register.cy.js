const user = {
  name: 'Fulano de Tal',
  email: 'fulano@mailinator.com',
  password: '123'
}

describe('Register', () => {
  it('Create account', () => {
    cy.visit('/')

    cy.contains('Registrar')
      .click()

    cy.get('[placeholder="Informe seu e-mail"]')
      .last()
      .type(user.email, { force: true })

    cy.get('[placeholder="Informe seu Nome"]')
      .last()
      .type(user.name, { force: true })

    cy.get('[placeholder="Informe sua senha"]')
      .last()
      .type(user.password, { force: true })

    cy.get('[placeholder="Informe a confirmação da senha"]')
      .last()
      .type(user.password, { force: true })

    cy.get('#toggleAddBalance')
      .click({ force: true })

    cy.contains('Cadastrar')
      .click({ force: true })

    cy.get('#modalText')
      .should('contain', 'foi criada com sucesso')
  })
})