import { ASPANGULARTemplatePage } from './app.po';

describe('ASPANGULAR App', function() {
  let page: ASPANGULARTemplatePage;

  beforeEach(() => {
    page = new ASPANGULARTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
