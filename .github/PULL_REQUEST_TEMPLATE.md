# Pull Request

## Description
<!-- Provide a brief description of the changes in this PR -->

## Type of Change
<!-- Mark the relevant option with an "x" -->
- [ ] Bug fix
- [ ] New feature
- [ ] Code refactoring
- [ ] Documentation update
- [ ] Database schema change
- [ ] Other (please describe):

## Checklist

### General
- [ ] My code follows the project's coding style
- [ ] I have performed a self-review of my own code
- [ ] I have commented my code, particularly in hard-to-understand areas
- [ ] My changes generate no new warnings

### Database Changes (Required for Discipline Module)
**✅ REQUIRED: If this PR modifies Models, Services, Controllers, DTOs, migrations, or triggers for the Discipline module:**
- [ ] **Verified with db.sql** - I have checked that all database-related changes are consistent with the schema defined in `db.sql`
- [ ] All column names, types, and constraints match `db.sql`
- [ ] All relationships and foreign keys are correctly defined as per `db.sql`
- [ ] Any triggers or stored procedures are documented in `db.sql`

### Testing
- [ ] I have added tests that prove my fix is effective or that my feature works
- [ ] New and existing unit tests pass locally with my changes
- [ ] Any dependent changes have been merged and published

## Related Issues
<!-- Link to related issues using #issue_number -->
Closes #

## Additional Notes
<!-- Add any additional information that reviewers should know -->
